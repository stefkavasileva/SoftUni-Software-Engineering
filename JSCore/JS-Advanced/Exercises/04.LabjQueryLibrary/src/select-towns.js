function attachEvents() {
   $('#items li').on('click',selectItem);
   $('#showTownsButton').on('click',getTowns);

   function selectItem() {
       if($(this).attr('data-selected')){
           $(this).attr('data-selected',false);
           $(this).css('background-color','');
       }else {
           $(this).attr('data-selected',true);
           $(this).css('background-color','#DDD');
       }
   }

   function getTowns() {
       let selectedTowns = $('#items li[data-selected]');
       $('#selectedTowns').text(selectedTowns.toArray().map(a => $(a).text()).join(', '));
   }
}
