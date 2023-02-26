import Payment from './PaymentPending'
import {getPayment, deletePayment,  updatePayment} from '../services/paymentAxios'
import '../index.css';
import {Box} from "@mui/material"
import React, {useEffect, useState} from 'react';
import HeaderUser from './HeaderUser'
import Cookies from 'universal-cookie'
import { useNavigate } from 'react-router'
import Button from "@mui/material/Button";
import ArrowBackIosIcon from '@mui/icons-material/ArrowBackIos';

const cookies = new Cookies();

const PaymentPendingControllerUser = () => {
    
    const [payments, setPayment] = useState([])
    const navigate = useNavigate()
    
    const deleteRegister = (id) => {
        deletePayment(id)
    }

    const updateRegister = (values) => {
        updatePayment(values)
    }

    useEffect(() => {
        async function loadPayment() {
            const response = await getPayment()

            if (response.status === 200) {
                setPayment(response.data)
            }
        }

        loadPayment()
        
    }, [])

    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "admin") {
            window.location.href = "./OwnerController"
        }
    })
    
    return (
        <>
            <Box>
                <HeaderUser />
                <br/><br/>
                <div className="container">
                <Button href="/MenuPayment" className="btn-back" variant='contained' color='success' startIcon={<ArrowBackIosIcon />}>BACK</Button><br/><br/>
                </div>
                <Payment payments={payments} deleteRegister={deleteRegister} updateRegister = {updateRegister} />
            </Box>
        
        </>
    )
}
export default PaymentPendingControllerUser