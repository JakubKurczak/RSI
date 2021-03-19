import java.io.Serializable;

public class Exercise implements Serializable {
    private static final long serialVersionUID = 101L;
    public int base;
    public int x;
    public int power;

    public double calculate() {
        return base * Math.pow(x, power);
    }
}