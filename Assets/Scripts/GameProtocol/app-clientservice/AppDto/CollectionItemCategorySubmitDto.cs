
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /**  */
  public class CollectionItemCategorySubmitDto : SubmitDto
  {



    /** 不足时导向npc编号 */
    public NpcInfoDto acceptNpc;
    
    /** 收集数量足够时提交npc编号 */
    public NpcInfoDto submitNpc;
    
    /** 收集物品编号 */
    public int itemCategoryId;
    

    private ItemCategory _itemCategory;
    public  ItemCategory itemCategory{
    	get
    	{
    		if (_itemCategory !=null){
				return _itemCategory;
			}else{
				_itemCategory = DataCache.getDtoByCls<ItemCategory>(itemCategoryId);
				return _itemCategory;
			}
    	}
    	set
    	{
    		_itemCategory = value;
    	}
    }
  }
}
