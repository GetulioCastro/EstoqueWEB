namespace EstoqueWEB.Areas.Admin.Models.FormModel
{
    public record LoginFormModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
