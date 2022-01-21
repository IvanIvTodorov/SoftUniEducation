function solve() {
   let button = document.getElementsByClassName('product-add');
   let display = document.getElementsByTagName('textarea')[0];
   let checkOut = document.getElementsByClassName('checkout')[0];
   
   checkOut.addEventListener('click', clicked);
   
   for (let index = 1; index < button.length; index++) {
      
      button[index].addEventListener('click', onClick);
   }

   let obj = [];
   
   function clicked(ev) {
      let arrNames = [];
      let sum = 0;
      for (const element of obj) {
         arrNames.push(element.name);
         sum += element.price;
      }
      let uniq = [... new Set(arrNames)];
      display.textContent += `You bought ${uniq.join(", ")} for ${sum.toFixed(2)}.`

      for (let index = 1; index < button.length; index++) {

         button[index].removeEventListener('click', onClick);
      }

      ev.target.removeEventListener('click', clicked);
   }

   function onClick(ev) {
      let price = Number(ev.target.parentNode.parentNode.getElementsByClassName('product-line-price')[0].textContent);
      let name = ev.target.parentNode.parentNode.getElementsByClassName('product-title')[0].textContent;

      display.textContent += `Added ${name} for ${price.toFixed(2)} to the cart.\n`;

      obj.push({
         name,
         price
      })
   }
}