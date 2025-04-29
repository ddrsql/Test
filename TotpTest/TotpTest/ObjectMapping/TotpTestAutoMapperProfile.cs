using AutoMapper;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using static TotpTest.Pages.Account.Components.ProfileManagementGroup.PersonalInfo.AccountProfilePersonalInfoManagementGroupViewComponent;

namespace TotpTest.ObjectMapping;

public class TotpTestAutoMapperProfile : Profile
{
    public TotpTestAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<ProfileDto, PersonalInfoModel>()
            .MapExtraProperties();
            //.Ignore(x => x.PhoneNumberConfirmed)
            //.Ignore(x => x.EmailConfirmed);

        CreateMap<PersonalInfoModel, UpdateProfileDto>()
            .MapExtraProperties();
    }
}
