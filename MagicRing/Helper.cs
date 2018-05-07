using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicRing{
    public class Counter{
    	private int counter;
    	public int Count{
    		get{ 
                return this.counter; 
            }
    	}
    	public Counter(int counter = 0){
    		this.counter = counter;
    	}
    	public void Inc(){
    		this.counter++;
    	}
    	public void Dec(){
    		this.counter--;
    	}
    	public void Reset(){
    		this.counter = 0;
    	}
    }
}