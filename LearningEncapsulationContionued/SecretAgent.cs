using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEncapsulationContionued
{
    class SecretAgent
    {
        // all strings should be private, otherwise EnemyAgent got access to all fields which should be protected. 
        public string Alias;
        public string RealName;
        public string Password;

        public string AgentGreeting(string word)
        {
            if (word == Password)
            {
                MessageBox.Show(RealName, "Agent mówi...");
                return RealName;
            }
            else
            {
                MessageBox.Show(Alias, "Cywil mówi...");
                return Alias;
            }
        }
    }
}
