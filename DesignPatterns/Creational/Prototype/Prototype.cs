using System.Collections;
using System.Text;

public class Prototype:IClonable<Prototype>{
    public int field1;
    public int field2;

    public Prototype(int field1,int field2){
        this.field1 = field1;
        this.field2 = field2;

    }


    public Prototype clone()
    {
        return new Prototype(this.field1, this.field2);
    }

    
}
