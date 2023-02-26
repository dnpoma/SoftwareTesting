import Payment from './PaymentAdmin'
import {getPayment, deletePayment,  updatePayment} from '../services/paymentAxios'
import '../index.css';
import {Box} from "@mui/material"
import React, {useEffect, useState} from 'react';
import GeneralMenu from './GeneralMenu';
import Cookies from 'universal-cookie'
import { useNavigate } from 'react-router'

const cookies = new Cookies();

const PaymentControllerAdmin = () => {
    
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
        if (cookies.get('ownerType') === "owner") {
            window.location.href = "./account"
        }
    })
    
    return (
        <>
            <Box >
                <GeneralMenu />
                <br/><br/>
                <Payment payments={payments} deleteRegister={deleteRegister} updateRegister = {updateRegister}/>
            </Box>
        
        </>
    )
}
export default PaymentControllerAdmin