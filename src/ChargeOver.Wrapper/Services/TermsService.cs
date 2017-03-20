using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TermsService : BaseService, ITermsService
	{
		public TermsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// List terms
		/// details: https://developer.chargeover.com/apidocs/rest/#list-terms
		/// </summary>
		public IResponse<Term> ListTerms()
		{
			return GetList<Term>("terms");
		}
	}
}
