function search() {
   let barInput = document.getElementById('searchText').value;
   let towns = document.querySelectorAll('ul li');

   let result = 0;
   for (const town of towns) {
      if (town.textContent.includes(barInput)) {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         result++
      }else{
         town.style.fontWeight = 'normal';
         town.style.textDecoration = 'none';
      }
   }
   
   return document.getElementById('result').textContent = `${result} matches found`;
}
