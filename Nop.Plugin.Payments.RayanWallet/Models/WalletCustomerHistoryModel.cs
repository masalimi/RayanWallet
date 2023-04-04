using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Payments.RayanWallet.Models
{
    public class WalletCustomerHistoryModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.OderId")]
        public int OrderId { get; set; }
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.OrderNo")]
        public string OrderNo { get; set; }
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.Amount")]
        public decimal Amount { get; set; }
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.CreateDate")]
        public string CreateDate { get; set; }
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.UpdateDate")]
        public string UpdateDate { get; set; }
        [NopResourceDisplayName("Plugins.Payment.Wallet.Fields.TransferTypeWallet")]
        public string TransferTypeWallet { get; set; }

    }

}
