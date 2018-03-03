
 
 //CallBacks using Ajax
   var APP  = (function() { //APPEAR TO MAKE IT CONSTATNT BY NAMING CONVENTION 
     //WHEN UPPER CASE YOU CAN USE IT AS IS.

     var ajax =  function(verb: any, url: any, data: any, pass: any, fail: any) {
          var xhr = new XMLHttpRequest();
          xhr.open(verb, url);
          xhr.onreadystatechange = function() {
               if (xhr.readyState == 4 && xhr.status == 200) {
                    pass(xhr.response);

               } else if (xhr.readyState == 4) {
                    fail(xhr.response);
			         }   
          };
          xhr.send();
     }

     return {
       ajax: ajax
     }


   })();
export {APP};