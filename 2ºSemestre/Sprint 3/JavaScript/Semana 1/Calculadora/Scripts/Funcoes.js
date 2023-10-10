      function Calcular() {
        //alert(`Bora calcular!!`)
        event.preventDefault();
        let num1 = parseFloat(document.getElementById("numero1").value);
        let num2 = parseFloat(document.getElementById("numero2").value);
        let res;
        let op = document.getElementById("Operacao").value;

        //mesma coisa de colocar um required nos inputs
        if (isNaN(num1) || isNaN(num2)) {
          alert("Preencha todos os campos!");
          return;
        }

        switch (op) {
          case "+":
            res = somar(num1, num2);

            break;

          case "-":
            res = subtrair(num1, num2);

            break;

          case "*":
            res = multiplicar(num1, num2);

            break;

          case "/":
            res = dividir(num1, num2);

            break;

          default:
            res = "Operação inválida!";
            break;
        }
        document.getElementById("resultado").innerText = res;
      }

      function somar(x, y) {
        return (x + y).toFixed(2);
      }

      function subtrair(x, y) {
        return (x - y).toFixed(2);
      }

      function multiplicar(x, y) {
        return (x * y).toFixed(2);
      }

      function dividir(x, y) {
        if (y == 0) {
          return "Impossível dividir por 0";
        }

        return (x / y).toFixed(2);
      }
