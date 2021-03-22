import java.io.Serializable;
import java.util.Random;

public class Exercise implements Serializable {
    private static final long serialVersionUID = 101L;
    public int base;
    public int x;
    public int power;

    public double calculate() {
        try {
            Random rand = new Random();
            Thread.sleep(rand.nextInt(5000) + 2000);
        }catch(Exception e){

        }
        return base * Math.pow(x, power);
    }
}