import LogoImage from './../images/Logo.png'
import AccountMenu from './MenuUser.jsx'
import '../css/style.css'

const HeaderUser = props => {
    return (
        <div className=" backgroundConteiner">
        <div className="row">
            <div className="col-2 ">
            <img src={LogoImage} alt="Logo" className="img-fluid " />
            </div>
            <div className="col-3 align-self-center">
            <h3>WELCOME USER</h3>
            </div>
            <div className="col-5 align-self-center">
            <AccountMenu/> 
            </div>

        </div>
        </div>

    )
}
export default HeaderUser
