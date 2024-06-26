﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerationEvent
{
    public partial class Form1 : Form
    {
        private int currentIndex = 0;
        private int[] N = new int[] { 10, 100, 1000, 10000 };  // Разные значения N

        public Form1()
        {
            InitializeComponent();
            AddDataToDataGridView();
        }

        private void AddDataToDataGridView()
        {
            // Добавление строк с данными
            string[] row0 = { "Все будет отлично", "0,20" };
            string[] row1 = { "Все будет хорошо", "0,20" };
            string[] row2 = { "Все будет неплохо", "0,10" };
            string[] row3 = { "Все будет плохо", "0,10" };
            string[] row4 = { "Все будет отвратительно", "0,25" };
            string[] row5 = { "Все будет ужасно отвратительно", "0,15" };

            probabilitiesDataGridView.Rows.Add(row0);
            probabilitiesDataGridView.Rows.Add(row1);
            probabilitiesDataGridView.Rows.Add(row2);
            probabilitiesDataGridView.Rows.Add(row3);
            probabilitiesDataGridView.Rows.Add(row4);
            probabilitiesDataGridView.Rows.Add(row5);
        }

        private void RunExperiments()
        {

            if (currentIndex >= N.Length)
            {
                MessageBox.Show("Все эксперименты выполнены");
                currentIndex = 0;  // Сбросить индекс, если нужно начать заново
                return;  // Выход, если все эксперименты уже выполнены
            }

            int n = N[currentIndex];
            List<Tuple<string, double>> events = new List<Tuple<string, double>>();
            foreach (DataGridViewRow row in probabilitiesDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    events.Add(Tuple.Create(row.Cells[0].Value.ToString(), Convert.ToDouble(row.Cells[1].Value)));
                }
            }

            StringBuilder results = new StringBuilder();
            results.AppendLine($"Эксперимент с N = {n}:");
            var counts = new Dictionary<string, int>();
            foreach (var evt in events)
            {
                counts[evt.Item1] = 0;
            }

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                double r = rand.NextDouble();
                double cumulative = 0;
                foreach (var evt in events)
                {
                    cumulative += evt.Item2;
                    if (r < cumulative)
                    {
                        counts[evt.Item1]++;
                        break;
                    }
                }
            }

            chart1.Series.Clear();
            foreach (var evt in events)
            {
                var series = chart1.Series.Add(evt.Item1);
                double empiricalProbability = (double)counts[evt.Item1] / n;
                series.Points.AddXY("Теоретическая", evt.Item2);
                series.Points.AddXY("Эмпирическая", empiricalProbability);
                results.AppendLine($"Событие {evt.Item1}: Теоретическая = {evt.Item2}, Эмпирическая = {empiricalProbability}");
            }
            results.AppendLine();

            resultTextBox.Text = results.ToString();
            results.AppendLine("Общий вывод: с увеличением N погрешность между теоретической и эмпирической вероятностями уменьшается, что демонстрирует закон больших чисел.");
            resultTextBox.Text = results.ToString();
            currentIndex++;  // Увеличиваем индекс для следующего нажатия кнопки
        }

        private void runExperimentButton_Click(object sender, EventArgs e)
        {
            RunExperiments();
        }
    }
}
