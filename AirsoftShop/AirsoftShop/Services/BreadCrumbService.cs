namespace AirsoftShop.Services
{
    public class BreadcrumbService
    {
        public List<BreadcrumbStep> Steps { get; private set; } = new();

        public BreadcrumbService()
        {
            Steps = new List<BreadcrumbStep>
        {
            new BreadcrumbStep("1. Produkty", "/Cart/Products"),
            new BreadcrumbStep("2. Dane zamawiającego", "/Cart/Order-Details"),
            new BreadcrumbStep("3. Dostawa i płatność", "/Cart/Shipping-Payment"),
            new BreadcrumbStep("4. Podsumowanie", "/Cart/Summary")
        };
        }

        public void UpdateActiveStep(string activeStep)
        {
            foreach (var step in Steps)
            {
                if (step.Link == activeStep)
                {
                    step.IsActive = true;
                    step.IsClickable = false;
                }
                else
                {
                    if (step.IsActive)
                    {
                        step.IsClickable = true;
                    }
                    step.IsActive = false;
                }
            }
        }
    }

    public class BreadcrumbStep
    {
        public string Title { get; }
        public string Link { get; }
        public bool IsActive { get; set; }
        public bool IsClickable { get; set; }

        public BreadcrumbStep(string title, string link)
        {
            Title = title;
            Link = link;
            IsActive = false;
            IsClickable = false;
        }
    }
}
