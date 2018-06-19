using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserList.Mvp.Views;

namespace UserList
{
    public partial class UserList : Form, IViewUserList
    {
        private readonly ApplicationContext context;

        public UserList(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        public new void Show()
         {
          context.MainForm = this;
        // base.Show();
          Application.Run(context);
        }
    }
}