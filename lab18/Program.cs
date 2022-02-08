using System;
using System.Xml;

namespace lab18
{
    class Program
    {
        static XmlDocument xDoc;
        static XmlElement xRoot;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            xDoc = new XmlDocument();
            xDoc.Load("XMLFile1.xml");
            xRoot = xDoc.DocumentElement;

            Console.Clear();
            Console.WriteLine("Главное меню:");
            Console.WriteLine(" 1. Вывести все элементы");
            Console.WriteLine(" 2. Добавить n-ый элемент");
            Console.WriteLine(" 3. Удалить n-ый элемент");
            Console.WriteLine(" 4. Завершить работу\n");
            Console.Write("Выбор: ");
            
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1: 
                    {
                        Show();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Введите номер позиции: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Add(n);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Введите номер позиции: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Remove(n);
                        break;
                    }
                case 4: { break; }
                default: Menu();
                    break;
            }
        }

        static void Show()
        {
            foreach (XmlNode xnode in xRoot)
            {
                Console.WriteLine();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "group")
                    {
                        Console.WriteLine("Группа: {0}", childnode.InnerText);
                    }
                    // если узел age
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine("Возраст: {0}", childnode.InnerText);
                    }
                }
            }

            Console.ReadLine();
            Menu();
        }

        static void Add(int n)
        {
            // создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("student");
            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            // создаем элементы company и age
            XmlElement companyElem = xDoc.CreateElement("group");
            XmlElement ageElem = xDoc.CreateElement("age");
            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(Console.ReadLine());
            Console.Write("Группа: ");
            XmlText companyText = xDoc.CreateTextNode(Console.ReadLine());
            Console.Write("Возраст: ");
            XmlText ageText = xDoc.CreateTextNode(Console.ReadLine());

            //добавляем узлы
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);

            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);

            if (n == 0)
            {
                XmlNode temp = xRoot.FirstChild;
                xRoot.InsertAfter(userElem, xRoot.FirstChild);
                xRoot.RemoveChild(xRoot.FirstChild);
                xRoot.InsertAfter(temp, xRoot.FirstChild);
            }
            else
            {
                int i = 1;
                foreach (XmlNode xnode in xRoot)
                {
                    if (i == n)
                    {
                        xRoot.InsertAfter(userElem, xnode);
                        break;
                    }
                    i++;
                }
            }
            xDoc.Save("XMLFile1.xml");

            Console.ReadLine();
            Menu();
        }

        static void Remove(int n)
        {
            if (n == 0)
            {
                xRoot.RemoveChild(xRoot.FirstChild);
            }
            else
            {
                int i = 1;
                foreach (XmlNode xnode in xRoot)
                {
                    if (i == n)
                    {
                        xRoot.RemoveChild(xnode);
                        break;
                    }
                    i++;
                }
            }
            xDoc.Save("XMLFile1.xml");

            Console.ReadLine();
            Menu();
        }
    }
}
