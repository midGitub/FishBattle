
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 技能演示 */
  public class SkillPreviewInfo 
  {



    /**  */
    public int id;
    
    /** 伤害，区分正负号，代表加血或减血 */
    public int damage;
    
    /** 我方人员 */
    public List<int> teamA;
    
    /** 我方阵型 */
    public int formationA;
    
    /** 敌方人员 */
    public List<int> teamB;
    
    /** 敌方阵型 */
    public int formationB;
    
    /** 技能目标位置 */
    public List<int> attackTargetIndex;
    

  }
}
