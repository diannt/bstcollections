using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BST.Collections.Collection;

namespace FormTest
{
    public partial class Form1 : Form
    {
        private System.Collections.Generic.SortedDictionary<string, Path> sortedBST;
        private Path temp = null;
        private string key;
        public Form1()
        {
            InitializeComponent(); 
            sortedBST = new System.Collections.Generic.SortedDictionary<string, Path>();
        }

        //Создание нового маршрута
        private void Generate_Click(object sender, EventArgs e)
        {
            temp = new Path();
            //пишем логи
            log.Text = temp.Read() + Environment.NewLine;
        }

        //Добавление маршрута в дерево
        private void Insert_Click(object sender, EventArgs e)
        {
            if (ke.Text != "")
            {
                key = ke.Text;
                log.Text = log.Text + "key " + key + " path: " + temp.Read() + Environment.NewLine;
                try
                {
                    //метод дерева принимает в себя ключ и объект маршрута
                    sortedBST.Add(key, temp);
                }
                catch (Exception ex)
                {
                    log.Text = log.Text + ex.Message + Environment.NewLine;
                }
            }
            else MessageBox.Show("Сначала напишите ключ!");
        }

        //поиск в дереве
        private void Search_Click(object sender, EventArgs e)
        {
            if (ke.Text != "")
            {
                key = ke.Text;
                Path sPath = null;
                
                log.Text = log.Text + "key " + key + Environment.NewLine;
                //если дерево содержит нужный нам ключ
                if (sortedBST.ContainsKey(key))
                {
                    //пытаемся получить его значение
                    if (sortedBST.TryGetValue(key, out sPath))
                        log.Text = log.Text + sPath.Read() + Environment.NewLine;
                    else
                    {
                        MessageBox.Show("Не получается взять значение!");
                    }
                }
                else
                {
                    MessageBox.Show("Значение не найдено");
                }
            }
            else
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        //удаление ключа из дерева
        private void button1_Click(object sender, EventArgs e)
        {

            if (ke.Text != "")
            {
                key = ke.Text;
                log.Text = log.Text + "key " + key + Environment.NewLine;
                //если ключ там
                if (sortedBST.ContainsKey(key))
                {
                    log.Text = log.Text + "Ключ найден!" + Environment.NewLine;
                    //удаляем его методами дерева
                    if (sortedBST.Remove(key))
                        log.Text = log.Text + "Ключ успешно удалён!" + Environment.NewLine;
                    else
                    {
                        MessageBox.Show("Нельзя удалить!");
                    }
                }
                else
                {
                    MessageBox.Show("В этом дереве нет таких ключей!");
                }
            }
        }

        //отображение дерева
        private void button2_Click(object sender, EventArgs e)
        {

            if (sortedBST.Keys.Count != 0)
            {
                //создаём итератор
                System.Collections.Generic.SortedDictionary<string, Path>.Enumerator ic = sortedBST.GetEnumerator();
               //и идём вглубь
                while (ic.MoveNext())
                {
                    log.Text = log.Text + ic.Current.Key + " " + ((Path)ic.Current.Value).Read() + Environment.NewLine;
                }
                log.Text = log.Text + "Дерево показано." + Environment.NewLine;
            }
            else
            {
                log.Text = log.Text + "Дерево закончилось" + Environment.NewLine;
            }
        }

        private void ke_MouseClick(object sender, MouseEventArgs e)
        {
            //если нажали на ключ и он остался таким же
            if (ke.Text == "Ключ")
            ke.Text = "";
        }
    }
}
