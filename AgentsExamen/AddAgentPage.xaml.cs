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
    /// Логика взаимодействия для AddAgentPage.xaml
    /// </summary>
    public partial class AddAgentPage : Page
    {
        Agents currentAgent = new Agents();
        public AddAgentPage(Agents agents)
        {
            InitializeComponent();
            typeAgent.ItemsSource = user9Entities.GetContext().TypeAget.ToList();
            if (agents != null)
            {
                currentAgent = agents;
            }
            DataContext = currentAgent;
        }

        private void AddAgent_Click(object sender, RoutedEventArgs e)
        {
            if (currentAgent.id == 0)
            {
                user9Entities.GetContext().Agents.Add(currentAgent);
            }
            try
            {
                user9Entities.GetContext().SaveChanges();
                MessageBox.Show("Удачно");
                Manager._frame.Navigate(new AgentListPage());
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void DelAgent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить агента", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            try
            {
                user9Entities.GetContext().Agents.Remove(currentAgent);
                user9Entities.GetContext().SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении");
            }


        }

        private void TypeAgent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
