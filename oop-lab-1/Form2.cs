using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Student:ICloneable,IComparable<Student>
        {
            public Student(string name,string spe,double asc)
            {
                this.Name = name;
                this.AverageScore = asc;
                this.Spe = spe;
            }
            public Student() { }

            public override string ToString()
            {
                return Name + " " + Spe + " " + " " + AverageScore;
            }

            public object Clone()
            {
                return new Student { Name = this.Name, AverageScore = this.AverageScore, Spe = this.Spe };
            }

            public int CompareTo(Student other)
            {
                if(this.AverageScore>other.AverageScore)
                {
                    return 1;
                }
                else
                {
                    if (this.AverageScore == other.AverageScore)
                        return 0;
                    else return -1;
                }
            }

            public static bool operator >(Student x1, Student x2)
            {
                if (x1.AverageScore > x2.AverageScore)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Student x1, Student x2)
            {
                if (x1.AverageScore < x2.AverageScore)
                    return true;
                else
                    return false;
            }

            public string Name { get; set; }
            public double AverageScore { get; set; }
            public string Spe { get; set; }
        }

        string[] Specialty = new string[] { "ИСиТ", "ПОИТ","ДЭВИ"};
        List<Student> students;

        private void buttonCreatCollection_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            try
            {
                if (!int.TryParse(textBoxSize.Text, out int collectionSize))
                    throw new Exception("Введены неверные данные");
                 students = new List<Student>();

                for(int i=0;i<collectionSize;)
                {
                    students.Add(new Student("студент" + (++i), Specialty[random.Next(0, Specialty.Length)],Math.Round((double)random.Next(20,51)/5,1)));
                    listBoxCollection.Items.Add(students.Last());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

            try
            {
                switch(((Button)sender).Text)
                {
                    case "↑":
                            Sort((x1,x2)=>x1>x2);
                        break;
                    case "↓":
                            Sort((x1,x2)=>x1<x2);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        public delegate bool Comparator(Student x1, Student x2);

        void Sort(Comparator comparator)
        {
            List<Student> list=new List<Student>();
            this.Controls.Add(this.buttonReset);
        
            try
            {
                for (int i = 0; i < students.Count; i++)
                {
                    list.Add((Student)students[i].Clone());
                }

                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count - 1; j++)
                    {
                        if (comparator(list[i], list[j]))
                        {
                            var temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
            finally
            {
                listBoxCollection.Items.Clear();
                listBoxCollection.Items.AddRange(list.ToArray());
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.buttonReset);
            listBoxCollection.Items.Clear();
            listBoxCollection.Items.AddRange(students.ToArray());
        }

        private void buttonLINQ_Click(object sender, EventArgs e)
        {
            try
            {
                listResoult.Items.Clear();
                switch (((Button)sender).Text)
                {
                    case "max":
                        listResoult.Items.Add(students.Max());
                        break;
                    case "min":
                        listResoult.Items.Add(students.Min());
                        break;
                    default:
                        listResoult.Items.AddRange(students.Where(i=>i.Spe=="ИСиТ").ToArray());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            
        }
    }
}
