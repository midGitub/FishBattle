
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 伙伴技巧 */
  public class CrewPassiveSkill : PassiveSkill
  {



    /** 战技等级上限 */
    public int maxGrade;
    
    /** 技能书ID */
    public int itemId;
    

    private AppItem _item;
    public  AppItem item{
    	get
    	{
    		if (_item !=null){
				return _item;
			}else{
				GeneralItem _value = DataCache.getDtoByCls<GeneralItem>(itemId);
				if ( _value == null )
					_item = null;	
				else if ( _value is AppItem )
					_item = (_value as AppItem);
				return _item;
			}
    	}
    	set
    	{
    		_item = value;
    	}
    }
  }
}
