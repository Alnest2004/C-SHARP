using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace LockFile
{
    public enum LockStatus
    {
        Unlocked,
        Locked
    }

    public class LockFilePresenter
    {
        private ILockFileView view;
        private string file2Lock = string.Empty;
        private FileStream fileLockStream = null;

        public LockFilePresenter(ILockFileView view)
        {
            this.view = view;
        }

        internal void LockFile()
        {
            if (string.IsNullOrEmpty(file2Lock) || !File.Exists(file2Lock))
            {
                view.ShowMessage("Please select a path to lock.");
                return;
            }

            if (fileLockStream != null)
            {
                view.ShowMessage("The path is already locked.");
                return;
            }
            try
            {
                fileLockStream = File.Open(file2Lock, FileMode.Open);
                fileLockStream.Lock(0, fileLockStream.Length);
                view.SetStatus(LockStatus.Locked);
            }
            catch (Exception ex)
            {
                fileLockStream = null;
                view.SetStatus(LockStatus.Unlocked);
                view.ShowMessage(string.Format("An error occurred locking the path.\r\n\r\n{0}", ex.Message));
            }
        }

        internal void UnlockFile()
        {
            if (fileLockStream == null)
            {
                view.ShowMessage("No path is currently locked.");
                return;
            }
            try
            {
                using (fileLockStream)
                    fileLockStream.Unlock(0, fileLockStream.Length);
            }
            catch (Exception ex)
            {
                view.ShowMessage(string.Format("An error occurred unlocking the path.\r\n\r\n{0}", ex.Message));
            }
            finally
            {
                fileLockStream = null;
            }
            view.SetStatus(LockStatus.Unlocked);
        }

        internal void SetFile(string path)
        {
            if (ValidateFile(path))
            {
                if (fileLockStream != null)
                    UnlockFile();
                view.SetStatus(LockStatus.Unlocked);
                file2Lock = path;
                view.SetFile(path);
            }
        }

        internal bool ValidateFile(string path)
        {
            bool exists = File.Exists(path);
            if (!exists)
                view.ShowMessage("File does not exist.");
            return exists;
        }
    }
}