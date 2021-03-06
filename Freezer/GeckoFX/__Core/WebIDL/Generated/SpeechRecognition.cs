namespace Gecko.WebIDL
{
    using System;
    
    
    internal class SpeechRecognition : WebIDLBase
    {
        
        public SpeechRecognition(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Grammars
        {
            get
            {
                return this.GetProperty<nsISupports>("grammars");
            }
            set
            {
                this.SetProperty("grammars", value);
            }
        }
        
        public string Lang
        {
            get
            {
                return this.GetProperty<string>("lang");
            }
            set
            {
                this.SetProperty("lang", value);
            }
        }
        
        public bool Continuous
        {
            get
            {
                return this.GetProperty<bool>("continuous");
            }
            set
            {
                this.SetProperty("continuous", value);
            }
        }
        
        public bool InterimResults
        {
            get
            {
                return this.GetProperty<bool>("interimResults");
            }
            set
            {
                this.SetProperty("interimResults", value);
            }
        }
        
        public uint MaxAlternatives
        {
            get
            {
                return this.GetProperty<uint>("maxAlternatives");
            }
            set
            {
                this.SetProperty("maxAlternatives", value);
            }
        }
        
        public string ServiceURI
        {
            get
            {
                return this.GetProperty<string>("serviceURI");
            }
            set
            {
                this.SetProperty("serviceURI", value);
            }
        }
        
        public void Start()
        {
            this.CallVoidMethod("start");
        }
        
        public void Start(nsISupports stream)
        {
            this.CallVoidMethod("start", stream);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
