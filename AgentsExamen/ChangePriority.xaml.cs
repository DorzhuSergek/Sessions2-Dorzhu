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
using System.Windows.Shapes;

namespace AgentsExamen
{
    /// <summary>
    /// Логика взаимодействия для ChangePriority.xaml
    /// </summary>
    public partial class ChangePriority : Window
    {
        Agents _currentAgent = new Agents();
        public ChangePriority(Agents agents)
        {
            InitializeComponent();
            txtPrioritet.Text = user9Entities.GetContext().Agents.Select(x => x.Приоритет).Max().ToString();
            if (agents != null)
            {
                _currentAgent = agents;
            }
            DataContext = _currentAgent;
        }
    }
}
