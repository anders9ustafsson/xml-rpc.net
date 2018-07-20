using System;
using CookComputing.XmlRpc;

public struct StateStructRequest
{
  public int state1;  
  public int state2;
  public int state3;
}

[XmlRpcUrl("http://www.cookcomputing.com/xmlrpcsamples/RPC2.ashx")]
public interface IStateName : IXmlRpcProxy
{
  [XmlRpcMethod("examples.getStateName")]
  string GetStateName(int stateNumber); 

  [XmlRpcMethod("examples.getStateNames")]
  string GetStateNames(StateStructRequest request);
}

