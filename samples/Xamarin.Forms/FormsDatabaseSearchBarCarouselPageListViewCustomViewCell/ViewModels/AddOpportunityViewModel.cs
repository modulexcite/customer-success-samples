﻿using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace InvestmentDataSampleApp
{
	public class AddOpportunityViewModel : BaseViewModel
	{
		OpportunityModel addOpportunityModel;

		public string Topic
		{
			get { return addOpportunityModel.Topic; }
			set
			{
				addOpportunityModel.Topic = value;
				OnPropertyChanged("Topic");
			}
		}

		public string Company
		{
			get { return addOpportunityModel.Company; }
			set
			{
				addOpportunityModel.Company = value;
				OnPropertyChanged("Company");
			}
		}

		public string DBA
		{
			get { return addOpportunityModel.DBA; }
			set
			{
				addOpportunityModel.DBA = value;
				OnPropertyChanged("DBA");
			}
		}

		public long LeaseAmount
		{
			get { return addOpportunityModel.LeaseAmount; }
			set
			{
				addOpportunityModel.LeaseAmount = value;
				OnPropertyChanged("LeaseAmount");
			}
		}

		public SalesStages SalesStage
		{
			get { return addOpportunityModel.SalesStage; }
			set
			{
				addOpportunityModel.SalesStage = value;
				OnPropertyChanged("SalesStage");
			}
		}

		public string Owner
		{
			get { return addOpportunityModel.Owner; }
			set
			{
				addOpportunityModel.Owner = value;
				OnPropertyChanged("Owner");
			}
		}

		public DateTime DateCreated
		{
			get { return addOpportunityModel.DateCreated; }
			set
			{
				addOpportunityModel.DateCreated = value;
				OnPropertyChanged("DateCreated");
			}
		}

		public ICommand SaveButtonTapped { protected set; get;}

		public AddOpportunityViewModel(AddOpportunityPage page)
		{
			addOpportunityModel = new OpportunityModel();
			SalesStage = SalesStages.New;

			SaveButtonTapped = new Command(() =>
			{
				DateCreated = DateTime.Now;
				Task.Run(() => App.Database.SaveOpportunity(addOpportunityModel));
				page.HandleSaveToDatabaseCompleted(page,new EventArgs());
			});
		}
	}
}

