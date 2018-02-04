
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 收集物品提交情况 */
  public class PickItemSubmitInfoDto : SubmitDto
  {



    /** 收集数量足够时提交npc编号 */
    public NpcInfoDto submitNpc;
    
    /**  */
    public List<PickItemPointDto> pickNpcs;
    
    /** 收集物品编号 */
    public int itemId;
    

    private GeneralItem _item;
    public  GeneralItem item{
    	get
    	{
    		if (_item !=null){
				return _item;
			}else{
				_item = DataCache.getDtoByCls<GeneralItem>(itemId);
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
