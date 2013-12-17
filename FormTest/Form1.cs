using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BST.Collections;

namespace FormTest
{
    public partial class Form1 : Form
    {
        private System.Collections.Generic.SortedDictionary<string, Dweller> sortedBST;
        private Dweller temp = null;
        private string key;
        public Form1()
        {
            InitializeComponent(); 
            //инициализируем дерево для добавления жителей
            sortedBST = new System.Collections.Generic.SortedDictionary<string, Dweller>();
        }

        //Создание нового жителя
        private void Generate_Click(object sender, EventArgs e)
        {
            temp = new Dweller();
            //запись о событии
            log.Text = temp.Print() + Environment.NewLine;
        }

        //Добавление маршрута в дерево
        private void Insert_Click(object sender, EventArgs e)
        {
            if (ke.Text != "")
            {
                key = ke.Text;
                log.Text = log.Text + "key " + key + " dweller: " + temp.Print() + Environment.NewLine;
                try
                {
                    //метод дерева принимает в себя ключ и объект жителя
                    sortedBST.Add(key, temp);
                }
                catch (Exception ex)
                {
                    log.Text = log.Text + ex.Message + Environment.NewLine;
                }
            }
            else MessageBox.Show("Сначала введите ключ!");
        }

        //поиск в дереве
        private void Search_Click(object sender, EventArgs e)
        {
            if (ke.Text != "")
            {
                key = ke.Text;
                Dweller sDweller = null;
                
                log.Text = log.Text + "key " + key + Environment.NewLine;
                //если дерево содержит нужный нам ключ
                if (sortedBST.ContainsKey(key))
                {
                    //пытаемся получить его значение
                    if (sortedBST.TryGetValue(key, out sDweller))
                        log.Text = log.Text + sDweller.Print() + Environment.NewLine;
                    else
                    {
                        MessageBox.Show("Не выходит взять значение!");
                    }
                }
                else
                {
                    MessageBox.Show("Значения нет");
                }
            }
            else
            {
                MessageBox.Show("Что-то не так!");
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
                        MessageBox.Show("Не получилось удалить!");
                    }
                }
                else
                {
                    MessageBox.Show("В этом дереве нет такого ключа!");
                }
            }
        }

        //отображение дерева
        private void button2_Click(object sender, EventArgs e)
        {

            if (sortedBST.Keys.Count != 0)
            {
                //создаём итератор
                System.Collections.Generic.SortedDictionary<string, Dweller>.Enumerator ic = sortedBST.GetEnumerator();
               //и идём вглубь
                while (ic.MoveNext())
                {
                    log.Text = log.Text + ic.Current.Key + " " + ((Dweller)ic.Current.Value).Print() + Environment.NewLine;
                }
                log.Text = log.Text + "Дерево отображено." + Environment.NewLine;
            }
            else
            {
                log.Text = log.Text + "Дерево завершилось" + Environment.NewLine;
            }
        }

        private void ke_MouseClick(object sender, MouseEventArgs e)
        {
            //если нажали на ключ и он по умолчанию
            if (ke.Text == "Ключ")
            ke.Text = "";
        }
    }
}
