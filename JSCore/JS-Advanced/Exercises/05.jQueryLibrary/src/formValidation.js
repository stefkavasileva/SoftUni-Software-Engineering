function validate() {
    $('#submit').on('click',validateForm);
    $('#company').on('change',checkBox);

    function validateForm(event) {
        let isUserNameValid = validField(/^[A-Za-z\d]{3,20}$/,'#username');
        let isEmailValid = validField(/^.*@.*\..*$/,'#email');

        let isPasswordsEqual = $('#password').val() === $('#confirm-password').val();
        if(isPasswordsEqual) {
            validField(/^\w{5,15}$/, '#password');
            validField(/^\w{5,15}$/, '#confirm-password');
        }else {
            $('#password').css('border-color','red');
            $('#confirm-password').css('border-color','red');
            isPasswordsEqual = false;
        }

        let isChecked = $('#company').is(':checked');
        let isCompanyValid;
        if(isChecked){
            isCompanyValid = validField(/^\d{4}$/,$('#companyNumber'));
        }

        let firstPartValid = isUserNameValid && isEmailValid && isPasswordsEqual;
        if((firstPartValid && !isChecked) || (isCompanyValid && firstPartValid && isChecked)){
            $('#valid').css('display','inline');
        }else {
            $('#valid').css('display','none');
        }

        event.preventDefault();

    }

    function validField(reg,fieldId) {
        let element = $(fieldId);
        let isValid ;
        let elementValue = element.val();
        if(!reg.test(elementValue)){
            $(element).css('border-color','red');
            isValid = false;
        }else{
            $(element).css('border-color','');
            isValid = true;
        }

        return isValid;
    }

    function checkBox() {
        if($(this).is(":checked")){
            $('#companyInfo').css('display','block');
        }else {
            $('#companyInfo').css('display','none');
        }
    }

}
