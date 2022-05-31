function expandedForm(num) {
      let numStr = num.toString().split('');
      
      for(let i = 0 ; i < numStr.length; i++ ){
          
          for(let y = numStr.length - i; y > 1; y--){
             numStr[i] += '0'; 
             // console.log(y);  use this to debug y, and no y value print out from console
          }
      }
      
     
      numStr = numStr.filter(value => !value.startsWith(0));
      return numStr.join(' + ')
    }
