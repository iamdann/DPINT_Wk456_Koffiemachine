using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaAndChocoLibrary;

namespace KoffieMachineDomain.Adapter
{
    public class TeaBlendRepositoryAdapter
    {
        private TeaBlendRepository teaBlendRepository;

        public TeaBlendRepositoryAdapter()
        {
            teaBlendRepository = new TeaBlendRepository();
        }

        public List<string> GetTeaBlendNames()
        {
            return teaBlendRepository.BlendNames.ToList();
        }

        public TeaAdapter GetTeaAdapter(string name)
        {
            return new TeaAdapter(teaBlendRepository.GetTeaBlend(name));
        }
    }
}
