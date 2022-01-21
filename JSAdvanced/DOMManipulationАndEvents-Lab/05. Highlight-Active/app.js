function focused() {
   let elements = document.querySelectorAll('input');

   for (const div of elements) {
       div.addEventListener('focus', onFocus);
       div.addEventListener('blur', onBlur);
   }

   function onFocus(ev){
    ev.target.parentNode.classList.add("focused");
   }

   function onBlur(ev){
       ev.target.parentNode.classList.remove('focused');
   }
}