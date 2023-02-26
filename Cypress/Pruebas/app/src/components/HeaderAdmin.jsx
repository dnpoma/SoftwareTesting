import LogoImage from './../images/Logo.png'
import AccountMenu from './MenuAdmin.jsx'
import '../css/style.css'

const HeaderAdmin = props => {
    return (
        <div className=" backgroundConteiner">
        <div className="row">
            <div className="col-2 ">
            <img src={LogoImage} alt="Logo" className="img-fluid " />
            </div>
            <div className="col-3 align-self-center">
            <h3>ADMIN MENU</h3>
            </div>
            <div className="col-5 align-self-center">
            <AccountMenu/> 
            </div>

        </div>
        </div>
    )
}
export default HeaderAdmin
