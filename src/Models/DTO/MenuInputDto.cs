using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Models.Entity;
using Models.Enum;

namespace Models.DTO
{
    /// <summary>
    /// �����˵�����ģ��
    /// </summary>
    public class MenuInputDto : BaseEntity
    {
        public MenuInputDto()
        {
            ParentId = 0;
            Status = Status.Available;
        }

        /// <summary>
        /// ����
        /// </summary>
        [Required(ErrorMessage = "�˵�������Ϊ�գ�"), MaxLength(16, ErrorMessage = "�˵����֧��16���ַ���"), MinLength(2, ErrorMessage = "�˵���������Ҫ2���ַ���")]
        public string Name { get; set; }

        /// <summary>
        /// ͼ��
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required(ErrorMessage = "�˵���URL����Ϊ�գ�"), StringLength(256, ErrorMessage = "URL�֧��256���ַ���")]
        public string Url { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [DefaultValue(0)]
        public int ParentId { get; set; }

        /// <summary>
        /// �˵�����
        /// </summary>
        [Required]
        public MenuType MenuType { get; set; }

        /// <summary>
        /// �Ƿ����±�ǩҳ��
        /// </summary>
        public bool NewTab { get; set; }
    }
}