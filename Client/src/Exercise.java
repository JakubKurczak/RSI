import java.io.Serializable;

public class Exercise implements Serializable {
    private static final long serialVersionUID = 101L;
    public int base;
    public int x;
    public int power;
    public Exercise (int base, int x, int power){
        this.base = base;
        this.x = x;
        this.power = power;
    }

}
