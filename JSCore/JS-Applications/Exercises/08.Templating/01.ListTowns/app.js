function attachEvents() {
    $('#btnLoadTowns').on('click', renderTowns);

    function renderTowns() {
        let towns = $('#towns')
            .val()
            .split(',')
            .map(e => ({
                name: e.trim()
            })).filter(e => e.name !== '');

        loadTowns(towns);
    }

    async function loadTowns(towns) {
        let source = await $.get('townTemplate.hbs');
        let compiled = Handlebars.compile(source);
        let template = compiled({
            towns
        });

        $('#root').html(template);
    }
}