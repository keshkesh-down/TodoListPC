using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
	internal class TodoModel: INotifyPropertyChanged
	{
		private bool isDone;
		private string text;

		public DateTime CreationDate { get; set; } = DateTime.Now;

		public bool IsDone
		{
			get { return isDone; }
			set
			{
				if (IsDone == value)
						return;
				isDone = value;
				OnPropertyChanged("IsDone");
			}
		}

		public string Text
		{
			get { return text; }
			set
			{
				if (text == value)
					return;
				text = value;
				OnPropertyChanged("Text");
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(propertyName, new PropertyChangedEventArgs(propertyName));
		}
	}
}
