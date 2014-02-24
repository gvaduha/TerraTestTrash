using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrasoftTestRunner;

namespace Test_I102
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
			Bind();

            CheckListBoxes();
		}

	    private void CheckListBoxes()
	    {
	        foreach (var control in Helper.GetAll(this, typeof (CheckedListBox)))
	        {
	            for (var i = 0; i < ((CheckedListBox) control).Items.Count; ++i)
	            {
	                ((CheckedListBox) control).SetItemChecked(i, true);
	            }
	        }
	    }

		public void Bind()
		{
			ApplicationType.DataSource = new BindingSource { DataSource = Dic.ApplicationType() };
			ApplicationType.DisplayMember = "Value";
			ApplicationType.ValueMember = "Key";

			CardCategory.DataSource = new BindingSource { DataSource = Dic.CardCategory() };
			CardCategory.DisplayMember = "Value";
			CardCategory.ValueMember = "Key";

			LastNameM.DataSource = new BindingSource { DataSource = Dic.LastNameM() };
			LastNameM.DisplayMember = "Value";

			LastNameG.DataSource = new BindingSource { DataSource = Dic.LastNameG() };
			LastNameG.DisplayMember = "Value";

			NameM.DataSource = new BindingSource { DataSource = Dic.NameM() };
			NameM.DisplayMember = "Value";

			NameG.DataSource = new BindingSource { DataSource = Dic.NameG() };
			NameG.DisplayMember = "Value";

			PaternalNameM.DataSource = new BindingSource { DataSource = Dic.PaternalNameM() };
			PaternalNameM.DisplayMember = "Value";

			PaternalNameG.DataSource = new BindingSource { DataSource = Dic.PaternalNameG() };
			PaternalNameG.DisplayMember = "Value";

			IsSecondNameNOTChanged.DataSource = new BindingSource { DataSource = Dic.TrueFalse() };
			IsSecondNameNOTChanged.DisplayMember = "Value";
			IsSecondNameNOTChanged.ValueMember = "Key";

			PreviousSecondName.DataSource = new BindingSource { DataSource = Dic.LastNameM() };
			PreviousSecondName.DisplayMember = "Value";

			Gender.DataSource = new BindingSource { DataSource = Dic.Gender() };
			Gender.DisplayMember = "Value";
			Gender.ValueMember = "Key";

			PlaceOfBirth.DataSource = new BindingSource { DataSource = Dic.PlaceOfBirth() };
			PlaceOfBirth.DisplayMember = "Value";

			IssuePlace.DataSource = new BindingSource { DataSource = Dic.PlaceOfBirth() };
			IssuePlace.DisplayMember = "Value";

			IssuedBy.DataSource = new BindingSource { DataSource = Dic.IssuedBy() };
			IssuedBy.DisplayMember = "Value";

			LineCodeKLADR.DataSource = new BindingSource { DataSource = Dic.LineCodeKLADR() };
			LineCodeKLADR.DisplayMember = "Value";
			LineCodeKLADR.ValueMember = "Key";

			DeliveryAddress.DataSource = new BindingSource { DataSource = Dic.DeliveryAddress() };
			DeliveryAddress.DisplayMember = "Value";
			DeliveryAddress.ValueMember = "Key";

			AccountName.DataSource = new BindingSource { DataSource = Dic.AccountName() };
			AccountName.DisplayMember = "Value";

			AccountType.DataSource = new BindingSource { DataSource = Dic.AccountType() };
			AccountType.DisplayMember = "Value";
			AccountType.ValueMember = "Key";

			LaborContractType.DataSource = new BindingSource { DataSource = Dic.LaborContractType() };
			LaborContractType.DisplayMember = "Value";
			LaborContractType.ValueMember = "Key";

			TotalWorkExperience.DataSource = new BindingSource { DataSource = Dic.TotalWorkExperience() };
			TotalWorkExperience.DisplayMember = "Value";
			TotalWorkExperience.ValueMember = "Key";

			LastSeniority.DataSource = new BindingSource { DataSource = Dic.CurrentWorkExperience() };
			LastSeniority.DisplayMember = "Value";
			LastSeniority.ValueMember = "Key";

			JobTitle.DataSource = new BindingSource { DataSource = Dic.JobTitle() };
			JobTitle.DisplayMember = "Value";
			JobTitle.ValueMember = "Key";

			IncomeCheckStatus.DataSource = new BindingSource { DataSource = Dic.IncomeCheckStatus() };
			IncomeCheckStatus.DisplayMember = "Value";
			IncomeCheckStatus.ValueMember = "Key";

			DeliveryAddressV.DataSource = new BindingSource { DataSource = Dic.DeliveryAddress() };
			DeliveryAddressV.DisplayMember = "Value";
			DeliveryAddressV.ValueMember = "Key";

			Education.DataSource = new BindingSource { DataSource = Dic.Education() };
			Education.DisplayMember = "Value";
			Education.ValueMember = "Key";

			MaritalStatus.DataSource = new BindingSource { DataSource = Dic.MaritalStatus() };
			MaritalStatus.DisplayMember = "Value";
			MaritalStatus.ValueMember = "Key";

			MinorChildrenNummber.DataSource = new BindingSource { DataSource = Dic.MinorChildrenNummber() };
			MinorChildrenNummber.DisplayMember = "Value";
			MinorChildrenNummber.ValueMember = "Key";

			ContactName.DataSource = new BindingSource { DataSource = Dic.NameM() };
			ContactName.DisplayMember = "Value";

			RelationDegree.DataSource = new BindingSource { DataSource = Dic.RelationDegree() };
			RelationDegree.DisplayMember = "Value";
			RelationDegree.ValueMember = "Key";

			IsNotPublicPerson.DataSource = new BindingSource { DataSource = Dic.TrueFalse() };
			IsNotPublicPerson.DisplayMember = "Value";
			IsNotPublicPerson.ValueMember = "Key";

			MaidenName.DataSource = new BindingSource { DataSource = Dic.LastNameG() };
			MaidenName.DisplayMember = "Value";

			SecretQuestion.DataSource = new BindingSource { DataSource = Dic.SecretQuestion() };
			SecretQuestion.DisplayMember = "Value";
			SecretQuestion.ValueMember = "Key";

			PreviousCreditsQuantity.DataSource = new BindingSource { DataSource = Dic.PreviousCreditsQuantity() };
			PreviousCreditsQuantity.DisplayMember = "Value";
			PreviousCreditsQuantity.ValueMember = "Key";

            AccountSphere.DataSource = new BindingSource { DataSource = Dic.AccountSphere() };
            AccountSphere.DisplayMember = "Value";
            AccountSphere.ValueMember = "Key";

            AccountCompanyEmployeesQty.DataSource = new BindingSource { DataSource = Dic.AccountCompanyEmployeesQty() };
            AccountCompanyEmployeesQty.DisplayMember = "Value";

            SecretWord.DataSource = new BindingSource { DataSource = Dic.SecretWord() };
            SecretWord.DisplayMember = "Value";

            BankingServiceCredit.DataSource = new BindingSource { DataSource = Dic.BankingServiceCredit() };
            BankingServiceCredit.DisplayMember = "Value";
            BankingServiceCredit.ValueMember = "Key";

            BankingServiceDebit.DataSource = new BindingSource { DataSource = Dic.BankingServiceDebit() };
            BankingServiceDebit.DisplayMember = "Value";
            BankingServiceDebit.ValueMember = "Key";

            CurrencyAsked.DataSource = new BindingSource { DataSource = Dic.CurrencyAsked() };
            CurrencyAsked.DisplayMember = "Value";
            CurrencyAsked.ValueMember = "Key";

            IsAgreeAuthorityTransfer.DataSource = new BindingSource { DataSource = Dic.TrueFalse() };
            IsAgreeAuthorityTransfer.DisplayMember = "Value";

            IsDataAuthentic.DataSource = new BindingSource { DataSource = Dic.TrueFalse() };
            IsDataAuthentic.DisplayMember = "Value";

            Street.DataSource = new BindingSource { DataSource = Dic.Street() };
            Street.DisplayMember = "Value";

            PercentPaymentMethod.DataSource = new BindingSource { DataSource = Dic.PercentPaymentMethod() };
            PercentPaymentMethod.DisplayMember = "Value";

            PercentPayment.DataSource = new BindingSource { DataSource = Dic.PercentPayment() };
            PercentPayment.DisplayMember = "Value";

            DependantsNumber.DataSource = new BindingSource { DataSource = Dic.DependantsNumber() };
            DependantsNumber.DisplayMember = "Value";
            DependantsNumber.ValueMember = "Key";

            EarlierCreditType.DataSource = new BindingSource { DataSource = Dic.EarlierCreditType() };
            EarlierCreditType.DisplayMember = "Value";
            EarlierCreditType.ValueMember = "Key";

            EarlierCreditStatuse.DataSource = new BindingSource { DataSource = Dic.EarlierCreditStatuse() };
            EarlierCreditStatuse.DisplayMember = "Value";
            EarlierCreditStatuse.ValueMember = "Key";

            EarlierBank.DataSource = new BindingSource { DataSource = Dic.EarlierBank() };
            EarlierBank.DisplayMember = "Value";
            EarlierBank.ValueMember = "Key";

            EarlierMaxLoanTerm.DataSource = new BindingSource { DataSource = Dic.EarlierMaxLoanTerm() };
            EarlierMaxLoanTerm.DisplayMember = "Value";
            EarlierMaxLoanTerm.ValueMember = "Key";

            ClientType.DataSource = new BindingSource { DataSource = Dic.ClientType() };
            ClientType.DisplayMember = "Value";
            ClientType.ValueMember = "Key";
        }

        /********************************************************************************************/

        #region "Controls update"

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                statusesFilePath.Text = openFileDialog.FileName;
        }

        private void UpdateStatus(string val)
        {
            statusString.Text = val;
        }

        private void SetRunningState(bool running = true)
        {
            uploadRequest.Enabled = !running;
            getStatuses.Enabled = !running;
            stopProcess.Enabled = running;
        }

        public void ReportUploadAppProgress(UploadAppSession s)
        {
            UpdateStatus(String.Format("{0:00000}>({1}) {2}:{3} [{4}] => {5} | {6} | {7} | {8}",
                ++_reqCnt, s.TimeToPerform,
                s.ResponseCode, s.ResponseMsg, s.IsSessionSavedToStorage,
                s.ApplicationType, s.BankingService, s.SmsCode, s.PhoneNumber));
        }

        public void ReportGetAppStatusProgress(GetAppStatusSession s)
        {
            UpdateStatus(String.Format("{0:00000}>({1}) {2}:{3} [{4}] => {5} | {6} | {7}",
                ++_reqCnt, s.TimeToPerform,
                s.Response.result.ErrorCode, s.Response.result.ErrorMessage, s.IsSessionSavedToStorage,
                s.Response.Status, s.Response.IdApplication, s.Response.Text));
        }

        #endregion "Controls update"

        CancellationTokenSource _cancelts = new CancellationTokenSource();
        int _reqCnt;

		private UploadAppSampleDataDictionary GetSampleData()
		{
			var r = new UploadAppSampleDataDictionary
			{
			    ApplicationType = ApplicationType.XKeys(),
                CreditTermAsked = new[] { CreditTermAskedFrom.Text.Toi(), CreditTermAskedTo.Text.Toi() },
                DepositTermAsked = new[] { DepositTermAskedFrom.Text.Toi(), DepositTermAskedTo.Text.Toi() },
                CreditLimitAsked = new[] { CreditLimitAskedFrom.Text.Toi(), CreditLimitAskedTo.Text.Toi() },
                DepositLimitAsked = new[] { DepositLimitAskedFrom.Text.Toi(), DepositLimitAskedTo.Text.Toi() },
			    CardCategory = CardCategory.XKeys(),
			    PaternalNameM = PaternalNameM.XVals(),
			    NameM = NameM.XVals(),
			    LastNameM = LastNameM.XVals(),
			    PaternalNameG = PaternalNameG.XVals(),
			    NameG = NameG.XVals(),
			    LastNameG = LastNameG.XVals(),
			    IsSecondNameNOTChanged = IsSecondNameNOTChanged.XKeys(),
			    PreviousSecondName = PreviousSecondName.XVals(),
			    PlaceOfBirth = PlaceOfBirth.XVals(),
                BirthDate = new[] { BirthDateFrom.Value, BirthDateTo.Value },
			    Gender = Gender.XKeys(),
                IssuedOn = new[] { IssuedOnFrom.Value, IssuedOnTo.Value },
			    IssuePlace = IssuePlace.XVals(),
			    IssuedBy = IssuedBy.XVals(),
			    LineCodeKLADR = LineCodeKLADR.XKeys(),
                Building = new[] { BuildingFrom.Text.Toi(), BuildingTo.Text.Toi() },
			    DeliveryAddress = DeliveryAddress.XKeys(),
			    AccountName = AccountName.XVals(),
			    AccountType = AccountType.XKeys(),
			    LaborContractType = LaborContractType.XKeys(),
			    TotalWorkExperience = TotalWorkExperience.XKeys(),
			    LastSeniority = LastSeniority.XKeys(),
			    JobTitle = JobTitle.XKeys(),
                AverageMonthlyIncome = new[] { AverageMonthlyIncomeFrom.Text.Toi(), AverageMonthlyIncomeTo.Text.Toi() },
			    IncomeCheckStatus = IncomeCheckStatus.XKeys(),
			    DeliveryAddressV = DeliveryAddressV.XKeys(),
			    Education = Education.XKeys(),
			    MaritalStatus = MaritalStatus.XKeys(),
			    MinorChildrenNummber = MinorChildrenNummber.XKeys(),
			    ContactName = ContactName.XVals(),
			    RelationDegree = RelationDegree.XKeys(),
			    IsNotPublicPerson = IsNotPublicPerson.XKeys(),
			    MaidenName = MaidenName.XVals(),
			    SecretQuestion = SecretQuestion.XKeys(),
			    PreviousCreditsQuantity = PreviousCreditsQuantity.XKeys(),
			    AccountSphere = AccountSphere.XKeys(),
			    AccountCompanyEmployeesQty = AccountCompanyEmployeesQty.XVals(),
			    SecretWord = SecretWord.XVals(),
                BankingServiceCredit = BankingServiceCredit.XKeys(),
                BankingServiceDebit = BankingServiceDebit.XKeys(),
                CurrencyAsked = CurrencyAsked.XKeys(),
			    IsAgreeAuthorityTransfer = IsAgreeAuthorityTransfer.XKeys(),
			    IsDataAuthentic = IsDataAuthentic.XKeys(),
			    Street = Street.XVals(),
                PercentPayment = PercentPayment.XVals(),
                PercentPaymentMethod = PercentPaymentMethod.XVals(),
                DependentsNumber = DependantsNumber.XKeys(),
                EarlierCreditStatuse = EarlierCreditStatuse.XKeys(),
                EarlierCreditType =  EarlierCreditType.XKeys(),
                EarlierBank = EarlierBank.XKeys(),
                EarlierMaxLoanTerm = EarlierMaxLoanTerm.XKeys(),
                ClientType = ClientType.XKeys(),
			};

		    return r;
		}

        private void StopProcessClick(object sender, EventArgs e)
        {
            _cancelts.Cancel();
            stopProcess.Enabled = false;
        }

        private void GetStatusesClick(object sender, EventArgs e)
        {
            GlobalRegistry.Objects["FakeReaderFilePath"] = statusesFilePath.Text;
 
            ExecuteRequests(
                () => TestPerformer.GetStatusRequests(getStatusFrom.Value, getStatusTo.Value, Convert.ToInt32(thrdNum.Text),
                    new Progress<GetAppStatusSession>(ReportGetAppStatusProgress),
                    _cancelts.Token)
                    );
        }

        private void UploadRequestClick(object sender, EventArgs e)
        {
            var samples = GetSampleData();
            UploadAppRequestBuilder reqBuilder;

            if ( useRandomBuilder.Checked )
            {
                reqBuilder = new RandomUploadAppRequestBuilder(); /*new RoundRobinUploadAppRequestBuilder()*/
            }
            else //Semi-random roundrobin builder
            {
                var rotatableLists = (new[] { samples.NameM, samples.LastNameM }).Cast<IList>();
                reqBuilder = new RoundRobinUploadAppRequestBuilder(rotatableLists);
            }

            ExecuteRequests(
                () => TestPerformer.UploadRequests(Convert.ToInt32(reqNumToUpload.Text), Convert.ToInt32(thrdNum.Text),
                    samples, reqBuilder,
                    new Progress<UploadAppSession>(ReportUploadAppProgress),
                    _cancelts.Token)
                    );
        }

	    async private void ExecuteRequests(Func<Task> action)
	    {
            int thrdnum = Convert.ToInt32(thrdNum.Text);
            GlobalRegistry.Objects["ThreadNum"] = thrdnum;

            _reqCnt = 0;
            SetRunningState();
            UpdateStatus("Starting...");

            try
            {
                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Error in processing op");
            }

            _cancelts = new CancellationTokenSource();
            SetRunningState(false);
        }
	}
}
