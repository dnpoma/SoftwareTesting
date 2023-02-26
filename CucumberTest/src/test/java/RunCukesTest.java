import cucumber.api.CucumberOptions;
import cucumber.api.testng.AbstractTestNGCucumberTests;

@CucumberOptions(features="src/test//java/features/search.feature",glue={"stepts"})
public class RunCukesTest extends AbstractTestNGCucumberTests{

}
