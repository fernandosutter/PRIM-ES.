public class ForcaBruta{

  public bool checkPrime(int x, int y){
    var isPrimeX = isPrime(x,y);

    if(isPrimeX){
      return true;
    }else{
      return false;
    }

  }

  public bool isPrime(int number1, int number2){
    var number = maxNumber(number1, number2);
    
    for (int i = 2; i < number; i++){
      if (number1 % i == 0 & number2 % i == 0){
        return false;
      }
    };
    return true;
  }

  public int maxNumber(int n1, int n2){
    if(n1 > n2){
      return n1;
    }else{
      return n2;
    }
  }
  
}