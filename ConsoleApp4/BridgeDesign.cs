using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // This is going to be an interface that acts as a bridge between the abstraction classes and implementer classes
    // The Implementor Interface defines the operations for all implementation classes.
    // It doesn't have to match the Abstraction's interface. 
    // In fact, the two interfaces can be entirely different. 

    public interface ILEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }

    // This is going to be a class which implements the ILEDTV interface and 
    // also provide the implementation details for the associated Abstraction class.
    // Each Concrete Implementation corresponds to a specific platform

    public class SamsungLedTv : ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }

    // Each Concrete Implementation corresponds to a specific platform
    // This is going to be a class and should implement the Implementation interface
    public class SonyLedTv : ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }

    //This is an abstract class that contains members that define an abstract business object and its functionality.
    //It contains a reference to an object of type ILEDTV and delegates all of the real work to this object.
    //It can also act as the base class for other abstractions.

    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }

    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractRemoteControl. 
    // This Redefined Abstraction Class extends the interface defined by AbstractRemoteControl class.
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }

    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractRemoteControl. 
    // This Redefined Abstraction Class extends the interface defined by AbstractRemoteControl class.
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }

    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractRemoteControl. 
    // This Redefined Abstraction Class extends the interface defined by AbstractRemoteControl class.
    public class LGRemoteControl : AbstractRemoteControl
    {
        public LGRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
