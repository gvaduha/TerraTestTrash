using System;
using System.Collections.Generic;
using System.Globalization;
using Test_I102;
using Test_I102.ServiceReferenceTerrasoft;

namespace TerrasoftTestRunner
{
	abstract public class UploadAppRequestBuilder
	{
	    protected abstract string GetNextDigitSequence(int length);
        protected abstract string GetNextAlphaNumSequence(int length);

	    protected abstract T GetNextValue<T>(IList<T> list);
        protected abstract DateTime GetNextRangeValue(IList<DateTime> range);
        protected abstract int GetNextRangeValue(IList<int> range);

	    public abstract IEnumerable<GenericApplication> Build(UploadAppSampleDataDictionary dataDictionary);

		protected GenericApplication ConstructObject(UploadAppSampleDataDictionary d)
		{
            // Common blocks
            var geninfo = ConstructGenericInfo(d);
            var regdoc = ConstructRegistrationDocument(d);
            var addresses = ConstructAddresses(d);
            var comms = ConstructCommunications();

		    CreditInfo credinfo = null;
		    DepositInfo depoinfo = null;
		    Employer empl = null;
		    EarlierAppointedCredit[] eapcr = null;

		    if (geninfo.ApplicationType == ApplicationTypes.credit)
		    {
		        // Credit blocks
		        credinfo = ConstructCredInfo(d);
		        empl = ConstructEmployer(d);

		        var prevcrednum = Convert.ToInt32(credinfo.PreviousCreditsQuantity);

		        if (prevcrednum > 0)
		        {
		            var prevcreds = new List<EarlierAppointedCredit>(prevcrednum);

		            for (var i = 0; i < prevcrednum; ++i)
		                prevcreds.Add(ConstructEarlierAppointedCredit(d));

		            eapcr = prevcreds.ToArray();
		        }
		        else
		        {
		            eapcr = new EarlierAppointedCredit[0];
		        }
		    }
		    else
		    {
		        // Depo blocks
		        depoinfo = ConstructDepositInfo(d);
		    }

		    var genapp = new GenericApplication
		    {
		        GenericInfo = geninfo,
		        DepositInfo = depoinfo,
		        CreditInfo = credinfo,
		        RegistrationDocument = regdoc,
		        Addresses = addresses,
		        Communications = comms,
		        Employer = empl,
                EarlierAppointedCredits = eapcr,
		    };

			return genapp;
        }

	    private GenericInfo ConstructGenericInfo(UploadAppSampleDataDictionary d)
        {
            var geninfo = new GenericInfo
            {
                ApplicationType = (ApplicationTypes)Enum.Parse(typeof(ApplicationTypes), GetNextValue(d.ApplicationType)),

                Gender = GetNextValue(d.Gender),

                IsSecondNameNOTChanged = Convert.ToBoolean(GetNextValue(d.IsSecondNameNOTChanged)),
                IsAgreeAuthorityTransfer = Convert.ToBoolean(GetNextValue(d.IsSecondNameNOTChanged)),
                SMScode = GetNextDigitSequence(6),
                BirthDate = GetNextRangeValue(d.BirthDate),
                PlaceOfBirth = GetNextValue(d.PlaceOfBirth),
                RegistrationDateOnAddress = GetNextRangeValue(d.IssuedOn),
                IsRegEqualFactAddress = Convert.ToBoolean(GetNextRangeValue(new []{0,1})),
                Citizenship = "643",
                ContactPhone = "+7" + GetNextDigitSequence(10),
                ContactName = GetNextValue(d.ContactName),
                RelationDegree = GetNextValue(d.RelationDegree),
                IsNotPublicPerson = true,
                MaidenName = GetNextValue(d.MaidenName),
                SecretQuestion = GetNextValue(d.SecretQuestion),
                SecretQuestionAnswer = GetNextValue(d.SecretQuestion),
                SecretWord = GetNextValue(d.SecretWord),
                TPin = GetNextDigitSequence(4),
                IsDataAuthentic = Convert.ToBoolean(GetNextValue(d.IsDataAuthentic)),
                CardCategory = GetNextValue(d.CardCategory),
                UserIP = String.Format("{0}.{1}.{2}.{3}", GetNextRangeValue(new []{1,255}),GetNextRangeValue(new []{1,255}),GetNextRangeValue(new []{1,255}),GetNextRangeValue(new []{1,255})),
                //TrafficSource = GetNextRangeValue(d.TrafficSource),
                //TrafficType = GetNextRangeValue(d.TrafficType),
                //AdvertContent = GetNextRangeValue(d.AdvertContent),
                //ContentAdvertKeyWord = GetNextRangeValue(d.ContentAdvertKeyWord),
                //AdvertCompanyProduct = GetNextRangeValue(d.AdvertCompanyProduct),
                //PageAddress = GetNextRangeValue(d.PageAddress),
                //PartnerMark = GetNextRangeValue(d.PartnerMark),
                ClientType = GetNextValue(d.ClientType),
                //FillingStartDate = GetNextRangeValue(d.FillingStartDate),
                SendingDateTime = DateTime.Now,
            };

            // Split card types to debit/credit
	        geninfo.BankingService = geninfo.ApplicationType == ApplicationTypes.credit ? GetNextValue(d.BankingServiceCredit) : GetNextValue(d.BankingServiceDebit);

            if (geninfo.Gender == "M")
            {
                geninfo.Name = GetNextValue(d.NameM);
                geninfo.PaternalName = GetNextValue(d.PaternalNameM);
                geninfo.LastName = GetNextValue(d.LastNameM);
            }
            else
            {
                geninfo.Name = GetNextValue(d.NameG);
                geninfo.PaternalName = GetNextValue(d.PaternalNameG);
                geninfo.LastName = GetNextValue(d.LastNameG);
            }

            geninfo.FirstNameRomanType = UberTranslit.GetTranslit(geninfo.Name);
            geninfo.SecondNameRomanType = UberTranslit.GetTranslit(geninfo.LastName);

            geninfo.CurrencyAsked = geninfo.ApplicationType == ApplicationTypes.credit ?
                "RUB" : GetNextValue(d.CurrencyAsked);

            return geninfo;
        }

        private RegistrationDocument ConstructRegistrationDocument(UploadAppSampleDataDictionary d)
        {
            return new RegistrationDocument
            {
                DocumentSeries = GetNextDigitSequence(4),
                DocumentNumber = GetNextDigitSequence(6),
                IssuedOn = GetNextRangeValue(d.IssuedOn),
                IssuedPlace = GetNextValue(d.IssuePlace),
                IssuedBy = GetNextValue(d.IssuedBy),
                IssueCode = GetNextDigitSequence(3) + "-" + GetNextDigitSequence(3),
            };
        }

        private Addresses ConstructAddresses(UploadAppSampleDataDictionary d)
	    {
            Func<Address> getAddr = () => new Address
            {
                Country = "643", //GetNextRangeValue(d.Country),
                Zip = GetNextDigitSequence(6),
                LineCodeKLADR = GetNextValue(d.LineCodeKLADR),
                Street = GetNextValue(d.Street), //GetNextRangeValue(d.Street),
                Building = GetNextRangeValue(new[] { 1, 150 }).ToString(CultureInfo.InvariantCulture),
                //OKATO = "45286585000",//GetNextRangeValue(d.OKATO),
                //StreetType = "ul",//GetNextRangeValue(d.StreetType),
            };

            return new Addresses
	        {
	            RegistrationAddress = getAddr(),
	            FactAddress = getAddr(),
	            WorkAddress = getAddr(),
	        };
	    }

	    private Communications ConstructCommunications()
	    {
	        return new Communications
	        {
	            mail = new Communication {Number = GetNextAlphaNumSequence(10)+"@"+GetNextAlphaNumSequence(6)+".ru"},
	            mobilePhone = new Communication { Number = "+7" + GetNextDigitSequence(10) },
	            mainPhone = new Communication { Number = "+7" + GetNextDigitSequence(10) },
	        };
	    }

	    private CreditInfo ConstructCredInfo(UploadAppSampleDataDictionary d)
	    {
	        var ci = new CreditInfo
	        {
	            IsAgreePersonalData = true,
	            DeliveryAddress = GetNextValue(d.DeliveryAddress),
	            AverageMonthlyIncome = GetNextRangeValue(d.AverageMonthlyIncome),
	            IncomeCheckStatus = GetNextValue(d.IncomeCheckStatus),
	            Education = GetNextValue(d.Education),
	            MaritalStatus = GetNextValue(d.MaritalStatus),
	            AverageMonthlyPartnerIncome = GetNextRangeValue(d.AverageMonthlyIncome),
	            MinorChildrenNumber = GetNextValue(d.MinorChildrenNummber),
	            DependentsNumber = GetNextValue(d.DependentsNumber),
	            PreviousCreditsQuantity = GetNextValue(d.PreviousCreditsQuantity),
	        };

            //don't pass terms and limits to credit and overdraft cards
	        if (d.BankingServiceCredit.Contains("PPT_CC1"))
	        {
                ci.CreditLimitAsked = GetNextRangeValue(d.CreditLimitAsked);
                ci.CreditTermAsked = GetNextRangeValue(d.CreditTermAsked);
            }

	        return ci;
	    }

        private EarlierAppointedCredit ConstructEarlierAppointedCredit(UploadAppSampleDataDictionary d)
        {
            return new EarlierAppointedCredit
            {
                Bank = GetNextValue(d.EarlierBank),
                CreditLimit = 0,
                CreditType = GetNextValue(d.EarlierCreditType),
                Currency = GetNextValue(d.CurrencyAsked),
                MaxLoanTerm = GetNextValue(d.EarlierMaxLoanTerm),
                OpenDate = DateTime.Now,
                Status = GetNextValue(d.EarlierCreditStatuse),
            };
        }

        private DepositInfo ConstructDepositInfo(UploadAppSampleDataDictionary d)
        {
            return new DepositInfo
            {
                DepositLimitAsked = GetNextRangeValue(d.DepositLimitAsked),
                DepositTermAsked = GetNextRangeValue(d.DepositTermAsked),
                PercentPayment = GetNextValue(d.PercentPayment),
                PercentPaymentMethod = GetNextValue(d.PercentPaymentMethod),
            };
        }

	    private Employer ConstructEmployer(UploadAppSampleDataDictionary d)
	    {
	        return new Employer
	        {
	            AccountName = GetNextValue(d.AccountName),
	            AccountType = GetNextValue(d.AccountType),
	            LaborContractType = GetNextValue(d.LaborContractType),
	            AccountSphere = GetNextValue(d.AccountSphere),
	            AccountCompanyEmployeesQty = GetNextValue(d.AccountCompanyEmployeesQty),
	            TotalWorkExperience = GetNextValue(d.TotalWorkExperience),
	            LastSeniority = GetNextValue(d.LastSeniority),
	            JobTitle = GetNextValue(d.JobTitle),
	        };
	    }
	}
}
