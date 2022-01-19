function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let rows = document.querySelectorAll('tbody tr');

      let input = document.getElementById('searchField').value;

         for (const content of rows) {
            if (content.textContent.includes(input)) {
               console.log(content);
               content.classList.add('select');
            }else{
               content.classList.remove('select');
            }       
         }

         document.getElementById('searchField').value = "";
   }
}