using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Features
{
    // 한국어 Lorem Ipsum
    // - 그냥 Random Text 생성하는 것임.
    // - https://amaze9001.tistory.com/31 
    public static class KoreanLipsum
    {
        private const string Base = "누구든지 병역의무의 이행으로 인하여 불이익한 처우를 받지 아니한다. 국회는 국가의 예산안을 심의·확정한다. 국회는 국정을 감사하거나 특정한 국정사안에 대하여 조사할 수 있으며, 이에 필요한 서류의 제출 또는 증인의 출석과 증언이나 의견의 진술을 요구할 수 있다.\r\n\r\n군사법원의 조직·권한 및 재판관의 자격은 법률로 정한다. 선거와 국민투표의 공정한 관리 및 정당에 관한 사무를 처리하기 위하여 선거관리위원회를 둔다.\r\n\r\n모든 국민은 직업선택의 자유를 가진다. 원장은 국회의 동의를 얻어 대통령이 임명하고, 그 임기는 4년으로 하며, 1차에 한하여 중임할 수 있다. 국회의 정기회는 법률이 정하는 바에 의하여 매년 1회 집회되며, 국회의 임시회는 대통령 또는 국회재적의원 4분의 1 이상의 요구에 의하여 집회된다.\r\n\r\n국가는 법률이 정하는 바에 의하여 재외국민을 보호할 의무를 진다. 국회는 헌법 또는 법률에 특별한 규정이 없는 한 재적의원 과반수의 출석과 출석의원 과반수의 찬성으로 의결한다. 가부동수인 때에는 부결된 것으로 본다.\r\n\r\n국무총리는 국무위원의 해임을 대통령에게 건의할 수 있다. 국가는 균형있는 국민경제의 성장 및 안정과 적정한 소득의 분배를 유지하고, 시장의 지배와 경제력의 남용을 방지하며, 경제주체간의 조화를 통한 경제의 민주화를 위하여 경제에 관한 규제와 조정을 할 수 있다.";
        private static readonly Random Random = new Random();

        public static string Get(int? length = null)
        {
            return Base.Substring(0, Random.Next(length ?? Base.Length));
        }
    }
}