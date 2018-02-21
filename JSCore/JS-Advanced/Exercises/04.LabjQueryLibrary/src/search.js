function search() {
    let inputValue = $('#searchText').val();
    let counter = 0;
    let lis = $('#towns li');
    for (let li of lis) {
        if($(li).text().toLowerCase().includes(inputValue.toLowerCase())){
            $(li).css("font-weight","bold");
            counter++;
        }else {
            $(li).css("font-weight","");
        }
    }
    console.log(lis.toArray().join(' '));

    $('#result').text(`${counter} matches found.`);
}