function attachEvents() {
    $('a.button').on('click',attachEventListener);

   function attachEventListener(){
       $('.selected').removeClass('selected');
       $(this).addClass('selected');
   }
}
