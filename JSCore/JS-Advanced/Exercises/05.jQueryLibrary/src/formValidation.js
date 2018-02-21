function validate() {
    $('#submit').on('click',validateForm);

    function validateForm() {

        let isUserNameValid = validField(/^[A-Za-z\d]{3,20}$/,'username');
        let isPasswordValid  = validField(/^\w{5,15}$/,'password') && validField(/^\w{5,15}$/,'confirm-password') ;
        isPasswordValid = $('#password').val() === $('#confirm-password');
        let isEmailValid = validField(/^.*@.*\..*$/,'email');

    }

    function validField(reg,fieldId) {
        let element = $(fieldId);
        let isValid ;
        if(!reg.test(element.val())){
            $(element).css('border-color','red');
            isValid = false;
        }else{
            $(element).css('border-color','');
            isValid = true;
        }

        return isValid;
    }

}
