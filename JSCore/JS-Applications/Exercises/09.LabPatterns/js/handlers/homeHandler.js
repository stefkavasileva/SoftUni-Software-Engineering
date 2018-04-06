handlers.homeHandler = function (ctx) {
    ctx.isAuth = auth.isAuth();

    $.ajax('data.json')
        .then((contacts) => {
            ctx.contacts = contacts;

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                navigation: './templates/common/navigation.hbs',
                footer: './templates/common/footer.hbs',
                contactPage: './templates/contacts/contactPage.hbs',
                contact: './templates/contacts/contact.hbs',
                contactDetails: './templates/contacts/contactDetails.hbs',
                contactsList: './templates/contacts/contactsList.hbs',
                loginForm: './templates/forms/loginForm.hbs'
            }).then(function () {
                ctx.partials = this.partials;

                render();
            });
        })
        .catch(console.error);

    function render () {
        ctx.partial('./templates/welcome.hbs')
            .then(attachEvents)
    }

    function attachEvents() {
        $('.contact').click((e) => {
            let index = $(e.target).closest('.contact').attr('data-id');
            ctx.selected = ctx.contacts[index];
            render();
        });
    }
};