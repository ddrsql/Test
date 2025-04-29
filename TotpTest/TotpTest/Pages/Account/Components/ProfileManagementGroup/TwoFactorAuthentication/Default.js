(function ($) {
    $(function () {
        var l = abp.localization.getResource("AbpAccount");

        $('#TwoFactorAuthenticationForm').submit(function (e) {
            debugger;
            e.preventDefault();

            if (!$('#TwoFactorAuthenticationForm').valid()) {
                return false;
            }

            var input = $('#TwoFactorAuthenticationForm').serializeFormToObject(false);

            abp.ajax($.extend(true, {
                url: abp.appPath + 'api/twofactor/enable',
                //type: 'PUT',
                data: JSON.stringify(input)
            }, null)).then(function (result) {
                abp.notify.success(JSON.stringify(result));
            });

            //volo.abp.account.profile.update(input).then(function (result) {
            //    abp.notify.success(l('PersonalSettingsSaved'));
            //    updateConcurrencyStamp();
            //});
        });
    });

    abp.event.on('passwordChanged', updateConcurrencyStamp);
    
    function updateConcurrencyStamp(){
        volo.abp.account.profile.get().then(function(profile){
            $("#ConcurrencyStamp").val(profile.concurrencyStamp);
        });
    }
})(jQuery);
