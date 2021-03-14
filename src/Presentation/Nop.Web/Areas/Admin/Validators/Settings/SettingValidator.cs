﻿using FluentValidation;
using Nop.Core.Domain.Configuration;
using Nop.Data;
using Nop.Data.DataBase;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Settings;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Settings
{
    public partial class SettingValidator : BaseNopValidator<SettingModel>
    {
        public SettingValidator(ILocalizationService localizationService, INopDataProvider<MerchantDB> dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.Configuration.Settings.AllSettings.Fields.Name.Required"));

            SetDatabaseValidationRules<Setting, MerchantDB>(dataProvider);
        }
    }
}