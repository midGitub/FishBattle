
//  G e n e r a t e d   f i l e .   D o   n o t   e d i t . 
// Generated By Gecko,if you need to edit it,extends it! 

//using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppDto
{  
  /** 所有方案的信息 */
  public class AllCaseInfoDto : GeneralResponse
  {



    /** 三个方案的信息 */
    public List<FormationCaseInfoDto> caseInfoDtos;
    
    /** 当前已经获得的伙伴 */
    public List<CrewInfoDto> crewInfoDtos;
    
    /** 主战伙伴的id */
    public long mainCrewId;
    
    /** 当前阵法方案 */
    public int activeAttackFormationCaseIndex;
    

  }
}
