using System.Collections.Generic;
using System.Windows;
using System;

namespace PracticalWork_10
{
    public partial class MainWindow : Window
    {
        List<int> expensesList = new List<int>();
        List<int> incomeList = new List<int>();
        int number = 1;
        private void AddValues_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(inputCosts.Text, out int value) && value > 0 && int.TryParse(inputProfit.Text, out int profit) && profit>0)
            {
                expensesList.Add(value);
                incomeList.Add(profit);
                expensesListBox.Items.Add(value);
                incomeListBox.Items.Add(profit);
                numbering.Items.Add(number);
                number++;
            }
            else MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            inputCosts.Clear();
            inputProfit.Clear();
            outEven.Clear();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (expensesListBox.Items.Count != 0)
            {
                for (int i = 0; i < expensesList.Count; i++)
                {
                    if (expensesList[i]> incomeList[i])
                    {
                        outEven.Text = Convert.ToString(i + 1);
                        return;
                    }
                }
                MessageBox.Show("Затраты на производство не превышают цены", "Итог поиска", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else MessageBox.Show("Введите значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            expensesList.Clear();
            incomeList.Clear();
            expensesListBox.Items.Clear();
            incomeListBox.Items.Clear();
            numbering.Items.Clear();
            inputCosts.Clear();
            inputProfit.Clear();
            outEven.Clear();
            number = 0;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа №10\nВ первом одномерном массиве хранятся затраты на производство продуктов, во втором — цены на эти продукты.Указать номер первого продукта, затраты на производство которого превышают цены", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
