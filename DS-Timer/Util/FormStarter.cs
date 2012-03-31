using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS_Timer.Util
{
	public class FormStarter
	{
		private Func<Form> m_FormCreate;

		public Form Form { get; private set; }

		public FormStarter(Func<Form> createMethod)
		{
			m_FormCreate = createMethod;
		}

		public void ShowForm() {
			if (Form == null || Form.IsDisposed)
			{
				Form = m_FormCreate.Invoke();
				Form.Show();
			}
			else
			{
				Form.Show();
				Form.BringToFront();
			}
		}


	}
}
