﻿using FluentValidation;
using Nop.Core.Domain.Orders;
using Nop.Data;
using Nop.Data.DataBase;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Orders;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Orders
{
    public partial class ReturnRequestValidator : BaseNopValidator<ReturnRequestModel>
    {
        public ReturnRequestValidator(ILocalizationService localizationService, INopDataProvider<MerchantDB> dataProvider)
        {
            RuleFor(x => x.ReasonForReturn).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ReturnRequests.Fields.ReasonForReturn.Required"));
            RuleFor(x => x.RequestedAction).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ReturnRequests.Fields.RequestedAction.Required"));

            SetDatabaseValidationRules<ReturnRequest, MerchantDB>(dataProvider);
        }
    }
}