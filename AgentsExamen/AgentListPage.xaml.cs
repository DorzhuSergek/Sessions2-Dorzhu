using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgentsExamen
{
    /// <summary>
    /// Логика взаимодействия для AgentListPage.xaml
    /// </summary>
    public partial class AgentListPage : Page
    {
        public AgentListPage()
        {
            InitializeComponent();
            lvAgent.ItemsSource = user9Entities.GetContext().Agents.ToList();
            List<string> types = new List<string>();
            types.Add("Все типы");
            types.Add("ЗАО");
            types.Add("МКК");
            types.Add("МФО");
            types.Add("ОАО");
            types.Add("ООО");
            types.Add("ПАО");
            cmbType.ItemsSource = types;
            List<string> filtr = new List<string>();
            filtr.Add("По наименовании (по возрастанию)");
            filtr.Add("По наименовании (по убыванию)");
            filtr.Add("По размеру скидки (по возрастанию)");
            filtr.Add("По размеру скидки (по убыванию)");
            filtr.Add("По приоритету (по возрастанию)");
            filtr.Add("По приоритету (по убыванию)");
            cmbFiltr.ItemsSource = filtr;
        }

        public void updateData()
        {
            IEnumerable<Agents> currentAgentList = user9Entities.GetContext().Agents.ToList();
            switch (cmbFiltr.SelectedIndex)
            {
                case 0:
                    currentAgentList = currentAgentList.OrderBy(x => x.НаименованиеАгента).ToList();
                    break;
                case 1:
                    currentAgentList = currentAgentList.OrderByDescending(x => x.НаименованиеАгента).ToList();
                    break;
                case 4:
                    currentAgentList = currentAgentList.OrderBy(x => x.Приоритет).ToList();
                    break;
                case 5:
                    currentAgentList = currentAgentList.OrderByDescending(x => x.Приоритет).ToList();
                    break;
            }
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    currentAgentList = user9Entities.GetContext().Agents.ToList() ;
                    break;
                case 1:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("ЗАО"));
                    break;
                case 2:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("МКК"));
                    break;
                case 3:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("МФО"));
                    break;
                case 4:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("ОАО"));
                    break;
                case 5:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("ООО"));
                    break;
                case 6:
                    currentAgentList = currentAgentList.Where(x => x.ТипАгента.Contains("ПАО"));
                    break;
            }
            currentAgentList = currentAgentList.Where(x => (x.НаименованиеАгента + " " + x.ТелефонАгента + " " + x.ЭлектроннаяПочтаАгента).ToLower().Contains(searchTxt.Text)).ToList();

            lvAgent.ItemsSource = currentAgentList;
        }

        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateData();
        }

        private void SearchTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager._frame.Navigate(new AddAgentPage(null));
        }

        private void LvAgent_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var agentList = lvAgent.SelectedItem as Agents;

            var agentItem = user9Entities.GetContext().Agents.Where(x => x.id == agentList.id).ToList()[0];
            Manager._frame.Navigate(new AddAgentPage(agentItem));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var agentList = lvAgent.SelectedItem as Agents;

            var agentItem = user9Entities.GetContext().Agents.Where(x => x.id == agentList.id).ToList()[0];
            ChangePriority change = new ChangePriority(agentItem);
            change.Show();
        }

        private void LvAgent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvAgent.SelectedItem != null)
            {
                changePrioritet.Visibility = Visibility.Visible;
            }
            else
            {
                changePrioritet.Visibility = Visibility.Hidden;
            }
        }
    }
}
