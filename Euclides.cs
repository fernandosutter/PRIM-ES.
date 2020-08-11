public class Euclides{

  public bool PrimoByEuclides(int x, int y)
  {
      var result = E(x, y);

      bool finalresult;
      finalresult = (result == 1) ?  true :  false;

      return finalresult;
  }

  public int E (int x, int y)
  {
    while(y != 0)
    {
      x = x%y;
      var aux = x;
      x = y;
      y = aux;
    }

    return x;
  }

}